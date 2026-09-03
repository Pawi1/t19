import './App.css';

let n = prompt("Podaj ostatni wyraz ciągu fibonacciego:")
let list = fibonacci(n);

function fibonacci(n) {
  let list = [1,1];
  for(let i = 2; i<n;i++)
    list.push(list[i-2] + list[i-1])
  return list;
}
function multiply(...args){
  let multiply = args[0];
  for(let i = 1; i<args.length; i++)
    multiply *= args[i];
  return multiply;
}

function App() {
  return (
    <div className='App'>
      <header>
        <h1>Obliczanie iloczynu n elementów ciągu Fibonacciego</h1>
        <img src='Fibonacci.jpg' />
      </header>
      <footer>
        <h3>Ciąg Fibonacciego</h3>
        <p>Iloczyn pierwszych {n} elementów ciągu Fibonacciego:<br />
        {list.toString().replaceAll(',','* ')}= {multiply(...list)}</p>
      </footer>
    </div>
  );
}

export default App;
