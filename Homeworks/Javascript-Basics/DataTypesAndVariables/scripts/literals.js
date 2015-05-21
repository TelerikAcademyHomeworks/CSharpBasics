taskName = "SomeName";

function Main(bufferElement) {
    SetSolveButton(function () {

        var boolean = true;
        WriteLine("This is boolean type: " + boolean);

        var integer = 10;
        WriteLine("This is integer type: " + integer);

        var floatingPoint = 10.3;
        WriteLine("This is floating point type: " + floatingPoint);

        var char = 'a';
        WriteLine("This is character type: " + char);

        var string = 'This is some text';
        WriteLine("This is string type: " + string);

        var undefined;
        WriteLine("This is undefined type: " + undefined);

        var nullable = null;
        WriteLine("This is nullable type: " + nullable);

        var objectType = new Number(5);
        WriteLine("This is object type: " + objectType);

        var notANumber = NaN;
        WriteLine("This is not a number: " + notANumber);
    });
}
