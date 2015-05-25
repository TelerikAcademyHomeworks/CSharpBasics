taskName = "Third digit checker";

function Main(bufferElement) {

    var number = ReadLine("Please enter a number to be checked: ");

    SetSolveButton(function () {
        var isThirdDigitSeven = ThirdDigitCheker(number.value);

        WriteLine(isThirdDigitSeven);
    });
}

function ThirdDigitCheker(number) {

    var reminder = 0;

    if(number < 100 ) {
        return false;
    }
    else {
        if(number < 1000) {
            reminder = number % 10;
            return (reminder === 7) ? true : false;
        }
        else {
            number = number % 1000;
            number = number / 100;
            reminder = Math.floor(number);
            return (reminder === 7) ? true : false;
        }
    }
}