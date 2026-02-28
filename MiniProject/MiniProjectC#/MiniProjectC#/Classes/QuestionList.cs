using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace MiniProjectC_.Classes
{
    public class QuestionList : List<Question>
    {
        private string filePath;

        public QuestionList(string filePath)
        {
            this.filePath = filePath;
        }

        public new void Add(Question q)
        {
            base.Add(q);

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(q.ToString());
            }
        }
    }
}
