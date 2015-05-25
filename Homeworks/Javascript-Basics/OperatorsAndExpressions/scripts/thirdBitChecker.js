taskName = "Third bit checker";

function Main(bufferElement) {

    var number = ReadLine("Please enter a number to be bit checked: ");

    SetSolveButton(function () {
        var isThirdBitOne = ThirdBitChecker(number.value)
        WriteLine(isThirdBitOne);
    });
}

function ThirdBitChecker(number) {
    var mask = 1;
    var thirdBit = number & (mask << 3);
    if( (thirdBit >> 3) === 1) {
        return true;
    }
    else{
        return false;
    }
}