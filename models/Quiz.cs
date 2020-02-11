﻿
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
using SimpleRepositoryFrameWork.Interfaces;
/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class movieQuiz
{

    private movieQuizQuiz[] quizField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("quiz")]
    public movieQuizQuiz[] quiz
    {
        get
        {
            return this.quizField;
        }
        set
        {
            this.quizField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class movieQuizQuiz:IEntity
{

    private movieQuizQuizQuestion[] questionsField;

    private string idField;

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("question", IsNullable = false)]
    public movieQuizQuizQuestion[] questions
    {
        get
        {
            return this.questionsField;
        }
        set
        {
            this.questionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class movieQuizQuizQuestion
{

    private movieQuizQuizQuestionAnswer[] answersField;

    private string idField;

    private string textField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("answer", IsNullable = false)]
    public movieQuizQuizQuestionAnswer[] answers
    {
        get
        {
            return this.answersField;
        }
        set
        {
            this.answersField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class movieQuizQuizQuestionAnswer
{

    private string idField;

    private string textField;

    private bool isCorrectField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool IsCorrect
    {
        get
        {
            return this.isCorrectField;
        }
        set
        {
            this.isCorrectField = value;
        }
    }
}

