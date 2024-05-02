using System;
using System.Globalization;
using System.Text;

abstract class DateTimeDecorator : IDateTimePrinter
{
    protected IDateTimePrinter dateTimePrinter;

    public DateTimeDecorator(IDateTimePrinter dateTimePrinter)
    {
        this.dateTimePrinter = dateTimePrinter;
    }
    public abstract string Print();
}

class PrefixDecorator : DateTimeDecorator
{
    private string prefix;

    public PrefixDecorator(IDateTimePrinter dateTimePrinter, string prefix) : base(dateTimePrinter)
    {
        this.prefix = prefix;
    }

    public override string Print()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(prefix);
        sb.Append(dateTimePrinter.Print());
        return sb.ToString();
    }
}

class SuffixDecorator : DateTimeDecorator
{
    private string suffix;

    public SuffixDecorator(IDateTimePrinter dateTimePrinter, string suffix) : base(dateTimePrinter)
    {
        this.suffix = suffix;
    }

    public override string Print()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(dateTimePrinter.Print());
        sb.Append(" ");
        sb.Append(suffix);
        return sb.ToString();
    }
}

interface IDateTimePrinter
{
    string Print();
}

class EuropeanDateTimePrinter : IDateTimePrinter
{
    public string Print()
    {
        return DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
    }
}

class AmericanDateTimePrinter : IDateTimePrinter
{
    public string Print()
    {
        return DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
    }
}
