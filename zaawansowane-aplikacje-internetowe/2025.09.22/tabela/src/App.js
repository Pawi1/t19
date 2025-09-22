import './App.css';

const LIST = [
  { imie: 'adam', nazwisko: 'KOWALSKI', wiek: '33' },
  { imie: 'ALA', nazwisko: 'nowak', wiek: '32' },
  { imie: 'Ola', nazwisko: 'SteFAnowska', wiek: '4' },
];

function isMature(age) {
  return age >= 18;
}

function formatText(text) {
  return text[0].toUpperCase() + text.substring(1).toLowerCase();
}

function App() {
  return (
    <div className="App">
      <table cellPadding="0" cellSpacing="0">
        <thead>
          <tr>
            <th>IMIE</th>
            <th>NAZWISKO</th>
            <th>WIEK</th>
            <th>CZY PEŁNOLETNI</th>
          </tr>
        </thead>
        <tbody>
          {LIST.map((person) => {
            const age = Number(person.wiek);
            return (
              <tr key={person.imie + person.nazwisko}>
                <td>{formatText(person.imie)}</td>
                <td>{formatText(person.nazwisko)}</td>
                <td>{person.wiek}</td>
                <td>{isMature(age) ? 'Tak' : 'Nie'}</td>
              </tr>
            );
          })}
        </tbody>
      </table>
    </div>
  );
}

export default App;
