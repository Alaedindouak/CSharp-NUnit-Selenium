using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using NUnit.Framework;
using Test_4.Models;

namespace Test_4
{
    [Order(2)]
    public class CreatePostTest : TestBase
    {
        private const string FILE_PATH = "/home/alaedin/Dev/test_files/posts.xml";

        public static IEnumerable<PostData> PostDataFromXmlFile()
        {
            return (List<PostData>) new XmlSerializer(typeof(List<PostData>))
                .Deserialize(new StreamReader(FILE_PATH));
        }

        [Test, TestCaseSource(nameof(PostDataFromXmlFile))]
        public void CreatePostTesting(PostData post)
        {
            app.Post.CreatePost(post);
            
            PostData actualPostData = app.Post.GetPostData();
          
            Assert.AreEqual(post.Title, actualPostData.Title);
            Assert.AreEqual(post.Tag, actualPostData.Tag);
            Assert.AreEqual(post.Content, actualPostData.Content);
        }
        
        // [Test]
        // public void CreatePostTesting()
        // {
        //     string title = "Test Celenium CSharp";
        //     string tag = "testing";
        //     string content = "test";
        //
        //     PostData post = new PostData(title, tag, content);
        //     
        //     app.Post.CreatePost(post);
        //     
        //     PostData actualPostData = app.Post.GetPostData();
        //   
        //     Assert.AreEqual(post.Title, actualPostData.Title);
        //     Assert.AreEqual(post.Tag, actualPostData.Tag);
        //     Assert.AreEqual(post.Content, actualPostData.Content);
        // }
    }
}