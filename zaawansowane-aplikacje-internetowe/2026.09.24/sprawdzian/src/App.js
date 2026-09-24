import './App.css';


let a = prompt("Podaj długość boku kwadratu:");
function calc(a)
{
  if(a>0)
    return a*a;
  else
    return "BŁĄD: Taki kwadrat nie istnieje";
}

function App() {
  return (
    <div className="App">
      <h1>Witaj w świecie geometrii</h1>
      <img src='/kwadrat.png' alt='kwadrat'></img>
      <p>Pole kwadratu o boku <span className='numbers'>{a}</span> jest równe <span  className='numbers'>{calc(a)}</span></p>
    </div>
  );
}

export default App;
