using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            //var patterns = new List<string> { 
            //    @"([A-Za-z]+).*\$(\d+.\d+)" 
            //};

            //var inputs = new List<string> {
            //    @"
            //      |-----------------------| 
            //      | Receipt from               |
            //      | Alexandru's shop        |
            //      |                                    |
            //      | Thanks for shopping! |
            //      |--------- |------------ |
            //      | Item       | Price $USD  |
            //      |--------- |-------------|
            //      | Shoes     |    $47.99     |
            //      | Cabbage|      $2.99      |
            //      | Carrots  |      $1.23      |
            //      | Chicken |      $9.99     |
            //      | Beef       |     $12.47     |
            //      | Shirt      |      $5.97      |
            //      | Salt        |      $2.99      |
            //      |---------|--------------|"
            //};

            //patterns.ForEach(pattern => {
            //    Console.WriteLine($"Regular expression: {pattern}");
            //    var regex = new Regex(pattern);
            //    inputs.ForEach(input =>
            //    {
            //        Console.WriteLine($"\tInput pattern {input}");

            //        var matches = regex.Matches(input);
            //        if (matches.Count <= 0)
            //        {
            //            Console.WriteLine($"\t\tNo matches found");
            //        }
            //        foreach (Match match in matches)
            //        {
            //            Console.WriteLine($"\t\tMatch at index {match.Index} with length {match.Length}");

            //            foreach (Group group in match.Groups)
            //            {
            //                Console.WriteLine($"\t\t\tGroup at index {group.Index} has value {group.Value}");
            //            }
            //        }

            //        Console.WriteLine("Simple replacement results: {0}", 
            //            Regex.Replace(input, @"(Chicken)(.*) \$(9.99)", @"$1$2 $$0.00"));

            //        var results = Regex.Replace(input, pattern, (match) => {
            //            if (match.Groups[1].Value == "Chicken")
            //            {
            //                return match.Value.Replace(match.Groups[2].Value, "0.00");
            //            }
            //            return match.Value;
            //        });
            //        Console.WriteLine($"Advanced replacement results {results}");
            //    });

            //});


            #endregion

            #region Anchors and Boundaries
            //var patterns = new List<string>
            //{
            //    @"\b",
            //    @"\B",
            //    @"^hi",
            //    @"hi$"
            //};

            //var inputs = new List<string>
            //{
            //    "a b",
            //    "a",
            //    " ",
            //    "hi ",
            //    " hi",
            //    " hi",
            //    "him",
            //    " him",
            //    "him "
            //};

            //patterns.ForEach(pattern =>
            //{
            //    Console.WriteLine($"Regular expression: {pattern}");
            //    var regex = new Regex(pattern);

            //    inputs.ForEach(input => {
            //        Console.WriteLine($"\tInput pattern: {input}");
            //        var results = regex.Matches(input);
            //        if (results.Count <= 0)
            //        {
            //            Console.WriteLine("\t\tNo matches found. ");
            //        }
            //        foreach (Match result in results)
            //        {
            //            Console.WriteLine($"\t\tMatch found at index {result.Index}. Length: {result.Length}");
            //        }
            //    });
            //});
            #endregion

            #region Requlat Expression Options

            //var patterns = new List<string>
            //{
            //    "(?x)Hey#This is a comment",
            //    "He(?# This is a comment...)y",
            //    "H(?i)e(?-i)y",
            //    @"(?m)^hey$",
            //    "(he)y",
            //    "(?n)(he)(?-n)y",
            //    "(?x) \r\n h e y"
            //};

            //var inputs = new List<string>
            //{
            //    "hey\nhey",
            //    " hey\nhey",
            //    " hey\n hey",
            //    "Hey",
            //    "hey",
            //    "HEy",
            //    "HEY",
            //    " hey",
            //    "hey ",
            //    " hey "
            //};

            //patterns.ForEach( pattern => {
            //    Console.WriteLine("Regular expression: \"{0}\"", pattern);
            //    var regex = new Regex(pattern);

            //    inputs.ForEach( input => {
            //        Console.WriteLine("\tInput pattern: \"{0}\"", input);
            //        var results = regex.Matches(input);

            //        if(results.Count <= 0)
            //            Console.WriteLine("\t\tNo matches found.");
            //        foreach (Match match in results)
            //        {
            //            Console.WriteLine("\t\tMatch found at index {0}. Length: {1}.", match.Index, match.Length);
            //            foreach (Group group in match.Groups)
            //            {
            //                Console.WriteLine("\t\t\tGroup at index {0} has value {1}", group.Index, group.Value);
            //            }
            //        }


            //    });
            //});
            #endregion

            #region Lookahead, Lookbehinds and Pruning
            //var patterns = new List<string>
            //{
            //    @"[A-Z]",
            //    "[A-Z-[Z]]",
            //    "a(?=b)",
            //    "a(?!b)",
            //    "(?<=c)a",
            //    "(?<!c)a"
            //};

            //var inputs = new List<string>
            //{
            //    "",
            //    "a'",
            //    "b'",
            //    "ab",
            //    "ca",
            //    "cab",
            //    "A",
            //    "Z",
            //    "AA"
            //};

            //patterns.ForEach(pattern => {
            //    Console.WriteLine("Regular expression: {0}", pattern);
            //    var regex = new Regex(pattern);

            //    inputs.ForEach(input => {
            //        Console.WriteLine("\tInput pattern: {0}", input);
            //        var results = regex.Matches(input);

            //        if(results.Count <= 0)
            //            Console.WriteLine("\t\tNo matches found.");
            //        foreach (Match result in results)
            //        {
            //            Console.WriteLine($"\t\tMatch found at index {result.Index}. Length: {result.Index}");
            //        }
            //    });


            //});

            #endregion

            #region Backtracking and Runaways
            //var patterns = new List<string>
            //{
            //    @"<.+>",
            //    @"<.+?>",
            //    @"(a+(aa)+(aaa)+(aa)+a+)+b."
            //};

            //var input = new List<string>
            //{
            //    "a<tag>b</tag>c",
            //    "aaaaaaaaaaaaaaaaaaaaab",
            //    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab"
            //};
            //patterns.ForEach(pattern => {
            //    Console.WriteLine($"Regular expression : {pattern}");
            //    var regex = new Regex(pattern);

            //    input.ForEach(input => {
            //        Console.WriteLine($"\tInput pattern {input}");
            //        var watch = new Stopwatch();
            //        watch.Start();

            //        var results = regex.Matches(input);

            //        if (results.Count <= 0)
            //        {
            //            Console.WriteLine($"\t\tMatches found.");
            //        }

            //        foreach (Match result in results)
            //        {
            //            Console.WriteLine($"\t\tMatch found at index {result.Index}.  Length:{result.Length}");
            //        }

            //        watch.Stop();
            //        Console.WriteLine($"\t\tRuntime: {watch.Elapsed.TotalMilliseconds}ms");

            //    });
            //});

            #endregion

            #region Introduction to Advanced Topics
            //var input = "a";
            //Console.WriteLine(input);
            //Console.WriteLine($"\tCode point: {GetCodePoint(input, 0)}");
            //Console.WriteLine($"\tLength: {input.Length}");

            //Console.WriteLine($"\tIs uppercase letter? {Regex.IsMatch(input, @"\p{Lu}")}");
            //Console.WriteLine($"\tIs uppercase letter? {Regex.IsMatch(input, @"\P{Lu}")}");


            //#endregion

            //#region Unicode and Culture
            //input = "❌";



            //Console.WriteLine("Cross Mark");
            //Console.WriteLine($"\tCode point: {GetCodePoint(input, 0)}");
            //Console.WriteLine($"\tLenght {input.Length}");

            //Console.WriteLine($"\tDoes the input match \\u274C? {Regex.IsMatch(input, "\u274C")}");

            //Console.WriteLine($"\tIs in Dingbats? {Regex.IsMatch(input, @"\p{IsDingbats}")}");
            //Console.WriteLine($"\tIs not in Dingbats? {Regex.IsMatch(input, @"\P{IsDingbats}")}");


            //input = "😎";
            //Console.WriteLine($"Smiling face with Sunglasses Emoji");
            //Console.WriteLine($"\tCode point: {GetCodePoint(input, 0)}");
            //Console.WriteLine($"\tLenght {input.Length}");
            //Console.WriteLine($"\tDoes the input match \\U001F60E? {Regex.IsMatch(input, "\U0001F60E")}");

            //input = "İ"; // In Turkish, capital i is not I. It is İ.
            //var pattern = "i";

            //Console.WriteLine("Turkish Culture");
            //Console.WriteLine($"\tMatches without CultureVariant? {Regex.IsMatch(input, pattern, RegexOptions.IgnoreCase)}");
            //Console.WriteLine($"\tMatches with CultureVariant? {Regex.IsMatch(input, pattern, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant)}");



            #endregion

            #region Captures and Balancing Grups

            //var input = "µ"; // Micro Sign
            //var pattern = "μ"; // Greek Small Letter Mu

            //Console.WriteLine("Micro and Mu Symbols:");
            //Console.WriteLine($"\tDoes {pattern} match {input}? {Regex.IsMatch(input, pattern)} ");

            //Console.WriteLine($"\tInput's code point: {GetCodePoint(input, 0)}");
            //Console.WriteLine($"\tPattern's code point: {GetCodePoint(pattern, 0)}");

            //input = "مرحبا بالعالم مرحبا"; // مرحبا means hello and بالعالم means world, as read from right to left.
            //pattern = @"مرحبا"; // مرحبا means hello.

            //Console.WriteLine("Right to Left Option");
            //Console.WriteLine($"\tWithout the RigthToLeft option:");
            //foreach (Match match in Regex.Matches(input, pattern))
            //{
            //    Console.WriteLine($"\t\tMatch at index {match.Index} of length {match.Length}");
            //}


            //Console.WriteLine($"\tWith the RigthToLeft option:");
            //foreach (Match match in Regex.Matches(input, pattern, RegexOptions.RightToLeft))
            //{
            //    Console.WriteLine($"\t\tMatch at index {match.Index} of length {match.Length}");
            //}

            //input = "Hello World.";
            //var patterns = new List<string> { @"\b\w+\b", @"\b(\w)+\b" };

            //Console.WriteLine("Captures: ");
            //foreach (var examplePattern in patterns)
            //{
            //    Console.WriteLine($"\tInput : {input}");
            //    Console.WriteLine($"\tPattern: {examplePattern}");

            //    foreach (Match match in Regex.Matches(input, examplePattern))
            //    {
            //        Console.WriteLine($"\t\t{match.Value} Match at index {match.Index} of length {match.Length}");

            //        foreach (Group group in match.Groups)
            //        {
            //            Console.WriteLine($"\t\t\t{group.Value} Group at index {group.Index} of length {group.Length}");

            //            foreach (Capture capture in group.Captures)
            //            {
            //                Console.WriteLine($"\t\t\t\t{capture.Value} Capture at index {capture.Index} of length {capture.Length}");
            //            }
            //        }
            //    }

            //}

            //input = @"{}";
            //pattern = @"^((?:[^{}]*)|(?<Open>{)|(?<-Open>}))*$";
            //Console.WriteLine("Balancing Groups:");
            //Console.WriteLine("\tInput: {0}", input);
            //Console.WriteLine("\tPattern: {0}", pattern);
            //Console.WriteLine("\tIs {0} balanced? {1}", input, Regex.IsMatch(input, pattern));
            //input = @"{}}";
            //Console.WriteLine("\tIs {0} balanced? {1}", input, Regex.IsMatch(input, pattern));
            //input = @"{}{";
            //Console.WriteLine("\tIs {0} balanced? {1}", input, Regex.IsMatch(input, pattern));
            //input = @"}{";
            //Console.WriteLine("\tIs {0} balanced? {1}", input, Regex.IsMatch(input, pattern));
            //input = @"{ {} {   }}";
            //Console.WriteLine("\tIs {0} balanced? {1}", input, Regex.IsMatch(input, pattern));

            //Console.WriteLine("Nested Captures:");
            //input = @"{ 1 { 2 3 } { 4 { 5 } 6 } 7 }";
            //pattern = @"^((?:[^{}]*)|(?<Open>{)|(?<Contents-Open>}))*(?(Open)(?!))$";

            //Console.WriteLine("\tInput: {0}", input);
            //Console.WriteLine("\tPattern: {0}", pattern);
            //var matches = Regex.Matches(input, pattern);
            //var contents = matches[0].Groups["Contents"];
            //Console.WriteLine("\t{0} Group:", contents.Name);
            //foreach (Capture capture in contents.Captures)
            //    Console.WriteLine("\t\t{0}: Capture at index {1} of length {2}", capture.Value, capture.Index, capture.Length);


            #endregion

            #region Optimization and Security
            Console.WriteLine("Interpreted Regex: ");

            var input = "The quick brown fox jumps over the lazy dog";
            var timer = new Stopwatch();
            timer.Start();

            var interpretedRegex = new Regex("(fox|dog)");
            for (int i = 0; i < 1000000; i++)
            {
                interpretedRegex.Match(input);
            }
            timer.Stop();
            Console.WriteLine($"\tInterpreted elapsed time: {timer.ElapsedMilliseconds}ms");
            Console.WriteLine($"\tCache size: {Regex.CacheSize}");

            Console.WriteLine("Compiled Regex: ");
            timer.Reset();
            timer.Start();
            var compiledRegex = new Regex("(fox|dog)", RegexOptions.Compiled);
            for (int i = 0; i < 1000000; i++)
            {
                interpretedRegex.Match(input);
            }
            timer.Stop();
            Console.WriteLine($"\tCompiled elapsed time: {timer.ElapsedMilliseconds}ms");
            Console.WriteLine($"\tCache size: {Regex.CacheSize}");

            Console.WriteLine("Slow Regex:");
            timer.Reset();
            timer.Start();
            Regex.IsMatch("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab", "(a+(aa)+(aaa)+(aa)+a+)+b.");
            timer.Stop();
            Console.WriteLine("\tElapsed time: {0}ms", timer.ElapsedMilliseconds);

            Console.WriteLine("Non-Capturing Regex:");
            timer.Reset();
            timer.Start();
            Regex.IsMatch("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab", "(?:a+(?:aa)+(?:aaa)+(?:aa)+a+)+b.");
            timer.Stop();
            Console.WriteLine("\tElapsed time: {0}ms", timer.ElapsedMilliseconds);

            Console.WriteLine("Lazy Regex:");
            timer.Reset();
            timer.Start();
            Regex.IsMatch("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab", "a+?b.");
            timer.Stop();
            Console.WriteLine("\tElapsed time: {0}ms", timer.ElapsedMilliseconds);

            Console.WriteLine("Timed Regex:");
            var timedRegex = new Regex("(a+(aa)+(aaa)+(aa)+a+)+b.", RegexOptions.None, TimeSpan.FromSeconds(1));
            try
            {
                timedRegex.IsMatch("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab");
            }
            catch (RegexMatchTimeoutException)
            {
                Console.WriteLine("\tThe match timed out.");
            }
            #endregion
        }

        private static object GetCodePoint(string input, int index)
        {
            if (Char.IsSurrogatePair(input, index))
            {
                return String.Format($"U +{Char.ConvertToUtf32(input, index):XB}");
            }

            return String.Format($"U+{Char.ConvertToUtf32(input, index):X4}");
        }
    }
}
