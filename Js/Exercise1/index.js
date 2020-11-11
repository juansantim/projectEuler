
(() => {
    const limit = 1000;

    let sum = 0;
    for (var i = 1; i < limit; i++) {
        if (isMultipleOf3Or5(i)) {
            console.log(i);
            sum += i;
        }
    }

    console.log(sum);

    function isMultipleOf3Or5(number) {
        return number % 5 === 0 || number % 3 === 0;;
    }

})()