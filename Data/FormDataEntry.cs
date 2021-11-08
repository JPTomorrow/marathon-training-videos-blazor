using System.Collections.Generic;
using System.IO;
using System.Text.Json;

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
        public A A { get; set; }
        public B B { get; set; }
        public C C { get; set; }
        public D D { get; set; }
    }

    public class Question
    {
        public string Text { get; set; }
        public Answers Answers { get; set; }
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
        public English English { get; set; }
        public Spanish Spanish { get; set; }
    }
}