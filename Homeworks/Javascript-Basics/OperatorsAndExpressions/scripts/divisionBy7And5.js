taskName = "Division By 7 and 5";

function Main(bufferElement) {

    var numberToCheck = ReadLine("Please enter the number to check: ");

    SetSolveButton(function () {
        var isDivisible = divisionBySevenAndFive(numberToCheck.value);

        WriteLine("Is the number divisible by 5 and 7 at the same time? -> " + isDivisible);
    });
}

function divisionBySevenAndFive(number) {
    return ((number % 5 === 0) && (number % 7 === 0)) ? true : false;
}