//@ts-check
import './App.css';
import {Calc} from './calc/Calc.js';
import SOLID from './data/solid.json';
let calc = new Calc()
function App() {
  return (
    <div className="App">
      <h1>Bryły</h1>
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
                <td><h2>{figure.name}</h2></td>
                <td><img src={figure.image} alt='figura'></img></td>
                <td>
                  <h3>pole: <span>{figure.formula.surfaceArea}</span></h3>
                  <h3>objętość: <span>{figure.formula.volume}</span></h3>
                </td>
                <td>
                  <div className='dimensions'>{
                  figure.exampleDimensions.map((dimension, index)=>(
                    <p>{index+1}. wymiar: {dimension} j</p>
                  ))
                  }</div>
                  <h3>pole: {calc.calc(figure.type,"surfaceArea",...figure.exampleDimensions)?.toFixed(0)} j²</h3>
                  <h3>objętość: {calc.calc(figure.type,"volume",...figure.exampleDimensions)?.toFixed(0)} j³</h3>
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
