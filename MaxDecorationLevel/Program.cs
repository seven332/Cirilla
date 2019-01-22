using Cirilla.Core.Models;
using Mono.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace MaxDecorationLevel
{
    class Program
    {
        private static string ProgramName
        {
            get
            {
                return Path.GetFileName(Assembly.GetExecutingAssembly().Location);
            }
        }

        static void Main(string[] args)
        {
            String input = null;
            String output = null;
            String style = null;
            var showVerbose = false;
            var showHelp = false;

            var options = new OptionSet {
                { "o|output=",    "The path of output .gmd file.",                                       o => output = o },
                { "s|style=",     "The style of inserted max decoration level, " +
                                  "like '%s <STYL MOJI_YELLOW_DEFAULT>(%d)</STYL>'. " +
                                  "'%s' is a placeholder for the original decoration name. " +
                                  "'%d' is a placeholder for the max decoration level. " +
                                  "'<STYL MOJI_YELLOW_DEFAULT>text</STYL>' writes 'text' in yellow.",    s => style = s },
                { "v|verbose",    "Show verbose information.",                                           v => showVerbose = v != null },
                { "h|help",       "Show this message and exit.",                                         h => showHelp = h != null },
            };

            try
            {
                List<string> extra = options.Parse(args);
                if (extra != null && extra.Count > 0)
                {
                    input = extra[0];
                }
            }
            catch (OptionException e)
            {
                Console.WriteLine($"{ProgramName}: {e.Message}");
                Console.WriteLine($"Try '{ProgramName} --help' for more information.");
                return;
            }

            if (showHelp)
            {
                ShowHelp(options);
                return;
            }

            if (input == null)
            {
                Console.WriteLine("The path of input .gmd file is required.");
                Console.WriteLine($"Try '{ProgramName} --help' for more information.");
                return;
            }

            InsertMaDecorationLevel(input, output, style, showVerbose);
        }

        private static void ShowHelp(OptionSet p)
        {
            Console.WriteLine("Insert max decoration level to .gmd files");
            Console.WriteLine($"Usage: {ProgramName} [OPTIONS]+ <input path>");
            Console.WriteLine();
            Console.WriteLine("Options:");
            p.WriteOptionDescriptions(Console.Out);
        }

        private static void InsertMaDecorationLevel(String input, String output, String style, Boolean showVerbose)
        {
            if (output == null)
            {
                output = input + ".mdl";
                if (showVerbose)
                {
                    Console.WriteLine("No explicated output. Use the default output.");
                }
            }

            GMD gmd = new GMD(input);

            if (style == null)
            {
                var language = gmd.Header.Language;
                if (language == 8 /* chS */ || language == 7 /* chT */ || language == 0 /* jpn */ || language == 6 /* kor */)
                {
                    style = "%s<STYL MOJI_YELLOW_DEFAULT>（%d）</STYL>";
                } else
                {
                    style = "%s <STYL MOJI_YELLOW_DEFAULT>(%d)</STYL>";
                }
                if (showVerbose)
                {
                    Console.WriteLine("No explicated style. Use the default style.");
                }
            }

            if (showVerbose)
            {
                Console.WriteLine($"input  = {input}");
                Console.WriteLine($"output = {output}");
                Console.WriteLine($"style  = {style}");
            }

            // Records which decoration has been modified
            var record = Data.MAX_DECORATION_LEVEL_MAP.Keys.ToDictionary(key => key, key => false);
            var recordCount = 0;

            var list = gmd.Entries.OfType<GMD_Entry>().ToList().FindAll(x => x.Key.StartsWith("JU_") && x.Key.EndsWith("_NAME"));
            foreach (var item in list)
            {
                if (!item.Value.Equals("Invalid Message"))
                {
                    if (Data.MAX_DECORATION_LEVEL_MAP.ContainsKey(item.Key))
                    {
                        var oldValue = item.Value;
                        item.Value = style.Replace("%s", item.Value).Replace("%d", Data.MAX_DECORATION_LEVEL_MAP[item.Key].ToString());
                        var newValue = item.Value;

                        if (showVerbose)
                        {
                            Console.WriteLine("Insert max decoration level:");
                            Console.WriteLine($"> Key       = {item.Key}");
                            Console.WriteLine($"> Old Value = {oldValue}");
                            Console.WriteLine($"> New Value = {newValue}");
                        }

                        if (record[item.Key] == false)
                        {
                            record[item.Key] = true;
                            recordCount++;
                        }
                    }
                    else if (!Data.INVALID_DECORATION_LIST.Contains(item.Key))
                    {
                        Console.WriteLine("Unknown decoration:");
                        Console.WriteLine($"> Key   = {item.Key}");
                        Console.WriteLine($"> Value = {item.Value}");
                    }
                }
            }

            // Show warning if not all decorations are modified
            if (recordCount != record.Count)
            {
                Console.WriteLine("Some decorations are missing:");
                foreach (var item in record)
                {
                    if (item.Value == false)
                    {
                        Console.WriteLine($"> {item.Key}");
                    }
                }
            }

            gmd.Save(output);
        }
    }
}
