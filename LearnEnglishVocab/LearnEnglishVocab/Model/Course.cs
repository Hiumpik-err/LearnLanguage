using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LearnEnglishVocab.Model
{
    public class Course
    {
        public int id { get;}
        public string courseName { get; set; }
        public string level { get; set; }
        public string language { get; set; }
        public string imagePath { get; set; }
        public List<Word> data { get; set; }

        public Course(string courseName, string level, string language, string englishMeaning, string polishMeaning)
        {
            this.courseName = courseName;
            this.level = level;
            this.language = language;
            this.imagePath = $"https://ui-avatars.com/api/?name={englishMeaning}+{polishMeaning}&background=random&size=128";
        }
        public Course(int id, string courseName, string level, string language, string imagePath)
        {
            this.id = id;
            this.courseName = courseName;
            this.level = level;
            this.language = language;
            this.imagePath = imagePath;
        }


    }
}
