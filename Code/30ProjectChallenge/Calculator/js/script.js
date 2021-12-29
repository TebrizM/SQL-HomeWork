class Calculator {
    constructor(previousOperand, currentOperand) {
        this.previousOperand = previousOperand;
        this.currentOperand = currentOperand;
        this.clear();
    }
    clear() {
        this.currentOperandText = '';
        this.previousOperandText = '';
        this.operation = undefined;

    }
    delete() {
        this.currentOperandText = this.currentOperandText.toString().slice(0, -1)

    }
    addNumber(number) {
        if (number === '.' && this.currentOperandText.includes('.')) {
            return;
        }
        this.currentOperandText = this.currentOperandText.toString() + number.toString();

    }
    chooseOperation(operation) {
        if (this.currentOperandText === '') {
            return
        }
        if (this.previousOperandText !== '') {
            this.compute()
        }

        this.operation = operation;
        this.previousOperandText = this.currentOperandText;
        this.currentOperandText = ''

    }
    compute() {
        let computation
        const prev = parseFloat(this.previousOperandText)
        const curr = parseFloat(this.currentOperandText)
        if (isNaN(prev) || isNaN(curr)) return
        switch (this.operation) {
            case '+':
                computation = prev + curr
                break;
            case '-':
                computation = prev - curr
                break;
            case '*':
                computation = prev * curr
                break;
            case '/':
                computation = prev / curr
                break;
            default:
                return;

        }
        this.currentOperandText = computation
        this.operation = undefined
        this.previousOperandText = ''
    }
    getDisplayNumber(number) {
        const stringNumber = number.toString()
        const integerDigits = parseFloat(stringNumber.split('.')[0])
        const decimalDigits = stringNumber.split('.')[1]

        let integerDisplay
        if (isNaN(integerDigits)) {
            integerDigits = ''
        } else {
            integerDisplay = integerDigits.toLocaleString('en', {
                maximumFractionDigits: 0
            })
        }
        if (decimalDigits != null) {
            return `${integerDisplay}.${decimalDigits}`
        } else {
            return integerDisplay
        }
    }
    updateDisplay() {
        this.currentOperand.innerText = this.getDisplayNumber(this.currentOperandText)
        if (this.operation != null) {

            this.previousOperand.innerText = `${this.getDisplayNumber(this.previousOperandText)} ${this.operation}`
        } else {
            this.previousOperand.innerText = ''
        }


    }

}

const numberbuttons = document.querySelectorAll('[data-number]');
const operationbuttons = document.querySelectorAll('[data-operation]');
const equalButton = document.querySelector('[data-equals]');
const deleteButton = document.querySelector('[data-delete]');
const allClearButton = document.querySelector('[data-all-clear]');
const previousOperand = document.querySelector('[data-previous]');
const currentOperand = document.querySelector('[data-current]');

const calculator = new Calculator(previousOperand, currentOperand)

numberbuttons.forEach(button => {
    button.addEventListener('click', () => {
        calculator.addNumber(button.innerText)
        calculator.updateDisplay()

    })
})
operationbuttons.forEach(button => {
    button.addEventListener('click', () => {
        calculator.chooseOperation(button.innerText)
        calculator.updateDisplay()

    })
})
equalButton.addEventListener('click', button => {
    calculator.compute();
    calculator.updateDisplay();

})
allClearButton.addEventListener('click', button => {
    calculator.clear();
    calculator.updateDisplay();

})
deleteButton.addEventListener('click', button => {
    calculator.delete();
    calculator.updateDisplay();

})