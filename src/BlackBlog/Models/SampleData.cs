using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BlackBlog.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<BlackBlogEntities>
    {
        protected override void Seed(BlackBlogEntities context)
        {
            new List<Post> 
            { 
                new Post {
                            Title = "Moodle, SCORM and Articulate Studio 09",
                            DateCreated = DateTime.Parse("07/05/2010"),
                            Author = "Kestrel",
                            Body = "<p>I’ve been to several Moodle courses recently and whilst they have been enjoyable there doesn’t seem to be much coverage on using Moodle with SCORM. It’s mostly been about using Moodle as a CMS to organise some type of structure for placing your course content ‘online’.</p>",
                            DatePublish = DateTime.Parse("07/05/2010")
                          },
                new Post {
                            Title = "VirtualBox 4.1.6 Error – VERR_LDR_MISMATCH_NATIVE",
                            DateCreated = DateTime.Parse("09/12/2011"),
                            Author = "Kestrel",
                            Body = "<p>So I decided to update my Ubuntu virtual machine from 9.1 to 10.04. After the upgrade of my Ubuntu system in my virtual machine I couldn’t get fullscreen mode to work so I also upgraded from an old version of VirtualBox to version 4.1.6.</p>",
                            DatePublish = DateTime.Parse("09/12/2011")
                          },
                 new Post {
                            Title = "Syntax Highlighting for WordPress",
                            DateCreated = DateTime.Parse("16/12/2011"),
                            Author = "Kestrel",
                            Body = "<p>I need a syntax highlighter if I am going to be placing code up on my blog. I went with CodeColorer after I noticed it supported a Railscasts theme. I’ve been reading Railscasts since the day I first started learning about RoR and it truly is awesome!</p>",
                            DatePublish = DateTime.Parse("16/12/2011")
                          },
            }.ForEach(a => context.Posts.Add(a));

           
        }
    }
}