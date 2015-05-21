taskName = "";

function Main(bufferElement) {

    SetSolveButton(function () {
        var boolean = true;
        WriteLine("This is boolean typeof: " + typeof(boolean));

        var integer = 10;
        WriteLine("This is integer typeof: " + typeof(integer));

        var floatingPoint = 10.3;
        WriteLine("This is floating point typeof: " + typeof(floatingPoint));

        var char = 'a';
        WriteLine("This is character typeof: " + typeof(char));

        var string = 'This is some text';
        WriteLine("This is string typeof: " + typeof(string));

        var undefined;
        WriteLine("This is undefined typeof: " + typeof(undefined));

        var nullable = null;
        WriteLine("This is nullable typeof: " + typeof(nullable));

        var objectType = new Number(5);
        WriteLine("This is object typeof: " + typeof(objectType));

        var array = [[4]];
        WriteLine("This is not a number typeof: " + typeof(array));

        var notANumber = NaN;
        WriteLine("This is not a number typeof: " + typeof(notANumber));
    });
}