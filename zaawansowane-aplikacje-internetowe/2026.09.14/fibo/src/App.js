import './App.css';

let n = prompt("Podaj długość ciągu fibonacciego:")
let list = fibonacci(n);

function fibonacci(n, list = [1,1]) {
  if (list.length >= n) return list;
  list.push(list[list.length - 2] + list[list.length - 1]);
  return fibonacci(n, list);
}
function multiply(...args){
  if (args.length === 1) return args[0];
  return args[0] * multiply(...args.slice(1));
}

export default function App() {
  return (
    <div className='App'>
      <header>
        <h1>Obliczanie iloczynu n elementów ciągu Fibonacciego</h1>
        <img src='Fibonacci.jpg' alt='fibonacci'/>
      </header>
      <footer>
        <h3>Ciąg Fibonacciego</h3>
        <p>Iloczyn pierwszych {n} elementów ciągu Fibonacciego:<br />
        {list.toString().replaceAll(',','* ')}= {multiply(...list)}</p>
      </footer>
    </div>
  );
}
