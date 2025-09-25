//@ts-check
import './App.css';

/**
 * @param {string} text
 */
function FormatNapisu(text){
  return text.toLowerCase().charAt(0).toUpperCase()+text.slice(1).toLowerCase();
}


/**
 * @param {{id: number; imie: string; nazwisko: string; kraj: string; utwory: { id: number; tytul: string; rodzaj: string; }[];}} pisarz
 */
function UtworyDruk(pisarz){
  return pisarz.utwory[0].tytul
}


/**
 * @param {{id: number; imie: string; nazwisko: string; kraj: string; utwory: { id: number; tytul: string; rodzaj: string; }[];}} pisarz
 */
function GatunekLiter(pisarz){
  return pisarz.utwory[0].rodzaj
}


const PISARZE = [
{"id":0,"imie":"adam","nazwisko":"mickiewicz","kraj":"polska",
  "utwory":[
    {"id":0,"tytul":"Pan Tadeusz","rodzaj":"epika"},
    {"id":1,"tytul":"Ballady i romanse","rodzaj":"liryka"},
    {"id":2,"tytul":"Dziady","rodzaj":"dramat"}
  ]
},
{"id":1,"imie":"jan", "nazwisko":"kochanowski","kraj":"polska",
 "utwory":[
  {"id":0,"tytul":"Odprawa poslow greckich","rodzaj":"dramat"},
  {"id":1,"tytul":"Fraszki","rodzaj":"liryka"}
 ]
},
{"id":2,"imie":"wiliam","nazwisko":"shakespeare","kraj":"anglia",
 "utwory":[
  {"id":0,"tytul":"Hamlet","rodzaj":"dramat"},
  {"id":1,"tytul":"Romeo i Julia","rodzaj":"dramat"},
  {"id":2,"tytul":"Juliusz Cezar","rodzaj":"dramat"}
 ]
},
{"id":3,"imie":"isaak","nazwisko":"asimow","kraj":"stany zjednoczone",
 "utwory":[
  {"id":0,"tytul":"Ja, robot", "rodzaj":"epika"},
  {"id":1,"tytul":"Koniec wiecznosci","rodzaj":"epika"}
 ]

}
];

function App() {
  return (
    <div className="App">
      <table cellPadding="0" cellSpacing="0">
        <thead>
          <tr>
            <th>AUTOR</th>
            <th>KRAJ</th>
            <th>UTWORY</th>
          </tr>
        </thead>
        <tbody>
          {PISARZE.map((pisarz,index)=>(
          <tr key ={pisarz.id}>
            <td><b><i>{FormatNapisu(pisarz.imie)} {FormatNapisu(pisarz.nazwisko)}</i></b></td>
            <td>{pisarz.kraj.toUpperCase()}</td>
            <td>
              <ol>
              {pisarz.utwory.map((utwor)=>(
                  <li key={utwor.id}><b>{utwor.tytul}</b> to {utwor.rodzaj}</li>
              ))}
              </ol>
              FUNKCJA UtworyDruk: {UtworyDruk(pisarz)} FUNKCJA GatunekLiter: {GatunekLiter(pisarz)}
            </td>
          </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default App;
