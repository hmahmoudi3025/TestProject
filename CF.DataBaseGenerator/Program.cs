using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CF.Model;

namespace CF.DataBaseGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var context = new BlogContext();
                var sdfdfg = context.Blogs.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
