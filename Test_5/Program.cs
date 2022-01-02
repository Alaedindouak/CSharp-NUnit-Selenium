using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

using Test_4.Models;


namespace Test_5
{

    public class Program
    {   
        const string PATH = "/home/alaedin/Dev/test_files";

        static void Main(string[] args)
        {
            string type = args[0];
            int count = Convert.ToInt32(args[1]);
            string filename = args[2];
            string format = args[3];
            
            if (type == "posts")
            {
                GeneratorForPosts(count, filename, format);
            }
            else
            {
                Console.WriteLine($"Unrecognized type of data {type}");
            }
            
        }

        static void GeneratorForPosts(int count, string filename, string format)
        {
            string file = $"{PATH}/{filename}.xml";
            List<PostData> posts = new List<PostData>();
            
            for (int i = 0; i < count; i++)
            {
                posts.Add(new PostData(WordGenerator.RandomWordGenerator(7), 
                    WordGenerator.RandomWordGenerator(4),
                 WordGenerator.RandomWordGenerator(20)));
            }
            
            if (File.Exists(file))
                File.Delete(file);

            if (format == "xml")
            {
                TextWriter writer = new StreamWriter(file);
                WritePostsToXMLFile(typeof(List<PostData>), posts, writer); 
                writer.Close();
            }
            else
            {
                Console.WriteLine($"Unrecognized format {format}");
            }
        }

        static void WritePostsToXMLFile(Type type, List<PostData> posts, TextWriter writer)
        {
            new XmlSerializer(type).Serialize(writer, posts);
        }
    }
}