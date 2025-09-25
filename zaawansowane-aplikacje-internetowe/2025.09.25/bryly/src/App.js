//@ts-check
import './App.css';
import {Calc} from './calc/Calc.js';
import SOLID from './data/solid.json';
let calc = new Calc()
function App() {
  return (
    <div className="App">
      <table cellPadding="0" cellSpacing="0">
        <thead>
          <tr>
            <th>BRYŁA</th>
            <th>ILUSTRACJA</th>
            <th>WZORY</th>
            <th>PRZYKŁAD</th>
          </tr>
        </thead>
        <tbody>
          {
            SOLID.map((figure)=>(
              <tr key ={figure.name}>
                <td>{figure.name}</td>
                <td><img src={figure.image} alt='figura'></img></td>
                <td>
                  <p>pole: <span>{figure.formula.surfaceArea}</span></p>
                  <p>objętość: <span>{figure.formula.volume}</span></p>
                </td>
                <td>
                  <p>wartosci: {figure.exampleDimension.toString()}</p>
                  <p>pole: {calc.calc(figure.type,"surfaceArea",...figure.exampleDimension)}</p>
                  <p>objętość: {calc.calc(figure.type,"volume",...figure.exampleDimension)}</p>
                </td>
              </tr>
            ))
          }
        </tbody>
      </table>
    </div>
  );
}

export default App;
