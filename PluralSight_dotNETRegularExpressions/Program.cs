﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PluralSight_dotNETRegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            //var patterns = new List<string> { "a*b", "a+b", "a?b" };
            //var inputs = new List<string> { "a", "b", "ab", "aab", "abb" };
            #region escaping patterns
            //var patterns = new List<string> { "\\?", @"\?", Regex.Escape("?") };
            //var inputs = new List<string> {"?" };

            //patterns.ForEach(pattern => {
            //    Console.WriteLine($"Regular expression {pattern}");
            //    var regex = new Regex(pattern);

            //    inputs.ForEach(input => {
            //        Console.WriteLine($"\tInput pattern: {input}");
            //        var results = regex.Matches(input);

            //        if (results.Count <= 0)
            //        {
            //            Console.WriteLine("\t\tNo Matches Found!");
            //        }

            //        foreach (Match result in results)
            //        {
            //            Console.WriteLine($"\t\tMatch found at index {result.Index}, length:{result.Length}");
            //        }
            //    });
            //});
            #endregion

            #region String Splitting
            //var patterns = new List<string>
            //{
            //    @"^\d\d\d-\d\d\d-\d\d\d\d$"
            //};

            //var inputs = new List<string>
            //{
            //    "5555555555",
            //    "(555)-555-5555",
            //    "012-345-6789",
            //    "555-555-5555",
            //    "555-555-555a",
            //    "555-5555555",
            //    "000-000-0000",
            //    "a",
            //    "5,55-555-5555",
            //    "...-...-...."
            //};

            //patterns.ForEach( pattern => {
            //    Console.WriteLine($"Regular expression {pattern}");
            //    var regex = new Regex(pattern);

            //    inputs.ForEach( input => {
            //        Console.WriteLine($"\tInput pattern: {input}");
            //        var isMatch = regex.IsMatch(input);
            //        string isMatchString = isMatch ? "Accepted" : "Rejected";
            //        Console.WriteLine($"\t\t{isMatchString}");

            //        if (!isMatch)
            //            return;

            //        var splits = Regex.Split(input, @"-\d\d\d-").ToList();
            //        Console.WriteLine($"\t\t\tArea Code: {splits[0]}");
            //        Console.WriteLine($"\t\t\tLast 4 digits: {splits[1]}");

            //    });
            //});
            #endregion

            #region Grouping and Substitution
            var patterns = new List<string> { 
                @"([A-Za-z]+).*\$(\d+.\d+)" 
            };

            var inputs = new List<string> {
                @"
                  |-----------------------| 
                  | Receipt from               |
                  | Alexandru's shop        |
                  |                                    |
                  | Thanks for shopping! |
                  |--------- |------------ |
                  | Item       | Price $USD  |
                  |--------- |-------------|
                  | Shoes     |    $47.99     |
                  | Cabbage|      $2.99      |
                  | Carrots  |      $1.23      |
                  | Chicken |      $9.99     |
                  | Beef       |     $12.47     |
                  | Shirt      |      $5.97      |
                  | Salt        |      $2.99      |
                  |---------|--------------|"
            };

            patterns.ForEach(pattern => {
                Console.WriteLine($"Regular expression: {pattern}");
                var regex = new Regex(pattern);
                inputs.ForEach(input =>
                {
                    Console.WriteLine($"\tInput pattern {input}");

                    var matches = regex.Matches(input);
                    if (matches.Count <= 0)
                    {
                        Console.WriteLine($"\t\tNo matches found");
                    }
                    foreach (Match match in matches)
                    {
                        Console.WriteLine($"\t\tMatch at index {match.Index} with length {match.Length}");

                        foreach (Group group in match.Groups)
                        {
                            Console.WriteLine($"\t\t\tGroup at index {group.Index} has value {group.Value}");
                        }
                    }

                    Console.WriteLine("Simple replacement results: {0}", 
                        Regex.Replace(input, @"(Chicken)(.*) \$(9.99)", @"$1$2 $$0.00"));

                    var results = Regex.Replace(input, pattern, (match) => {
                        if (match.Groups[1].Value == "Chicken")
                        {
                            return match.Value.Replace(match.Groups[2].Value, "0.00");
                        }
                        return match.Value;
                    });
                    Console.WriteLine($"Advanced replacement results {results}");
                });
            
            });
       

            #endregion


        }
    }
}
