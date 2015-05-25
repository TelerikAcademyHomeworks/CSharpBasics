taskName = "Odd or Even";

function Main(bufferElement) {

    var numberToCheck = ReadLine("Please enter a number to be checked: ");

    SetSolveButton(function () {

        var isEven = oddEvenNumberChecker(numberToCheck.value);
        WriteLine("Is the number even? -> " + isEven);

    });
}

function oddEvenNumberChecker(number) {
    return (number % 2 === 0) ? true : false;
}