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
            SOLID.map((solid)=>(
              <tr key ={solid.name}>
                <td><h2>{solid.name}</h2></td>
                <td><img src={solid.image} alt='figura'></img></td>
                <td>
                  <h3>pole: <span>{solid.formula.surfaceArea}</span></h3>
                  <h3>objętość: <span>{solid.formula.volume}</span></h3>
                </td>
                <td>
                  <div className='dimensions'>{
                  solid.exampleDimensions.map((dimension, index)=>(
                    <p>{index+1}. wymiar: {dimension} j</p>
                  ))
                  }</div>
                  <h3>pole: {calc.calc(solid.type,"surfaceArea",...solid.exampleDimensions)?.toFixed(0)} j²</h3>
                  <h3>objętość: {calc.calc(solid.type,"volume",...solid.exampleDimensions)?.toFixed(0)} j³</h3>
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
