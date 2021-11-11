using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;

namespace MarathonTutorialWebsite.Data
{
    public class A
    {
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
    }

    public class B
    {
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
    }

    public class C
    {
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
    }

    public class D
    {
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
    }

    public class Answers
    {
        public A A { get; set; } = null;
        public B B { get; set; } = null;
        public C C { get; set; } = null;
        public D D { get; set; } = null;
    }

    public class Question
    {
        public string Text { get; set; }
        public Answers Answers { get; set; }
        public string SelectedAnswer { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

    public class English
    {
        public List<Question> Questions { get; set; }
    }

    public class Spanish
    {
        public List<Question> Questions { get; set; }
    }

    public class FormDataEntry
    {
        [Required]
        [StringLength(50)]
        public string FullName { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; } = string.Empty;

        public English English { get; set; }
        public Spanish Spanish { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}