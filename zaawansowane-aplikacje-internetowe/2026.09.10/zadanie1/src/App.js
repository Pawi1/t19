import './App.css';

function Hello(props) {
  return <p>{props.name} witaj z funkcji Witaj()</p>
}

export default function App() {
  let person = String(prompt("Jak masz na imie"));
  return (
    <div className="App">
      <h2>Hello, World!</h2>
      <Hello name={person} />
    </div>
  );
}
