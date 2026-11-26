import { useState } from 'react';
import Graph from './Graph';

const number = /^-?\d+(\.\d+)?$/;

export default function Calc() {
    const [values, setValues] = useState({ a: '', b: '', c: '' });
    const [error, setError] = useState('');
    const [result, setResult] = useState(null);

    function handleChange(e) {
        setValues({ ...values, [e.target.id]: e.target.value });
        setResult(null);
    }

    function handleBlur(e) {
        const v = e.target.value.trim();
        if (v !== '' && !number.test(v)) {
            setError('Podano bledne dane, UWAGA: separator dziesietny to . (kropka)');
        } else if (['a', 'b', 'c'].every(k => values[k].trim() === '' || number.test(values[k].trim()))) {
            setError('');
        }
    }

    function calculate() {
        if (!['a', 'b', 'c'].every(k => number.test(values[k].trim()))) {
            setError('A jednak podane zostaly zle dane: tylko liczby, separator dziesietny to . (kropka)');
            setResult(null);
            return;
        }
        const a = parseFloat(values.a);
        const b = parseFloat(values.b);
        const c = parseFloat(values.c);
        if (a === 0) {
            setError('To nie jest rownanie kwadratowe: a nie moze byc rowne 0');
            setResult(null);
            return;
        }
        setError('');
        const delta = b * b - 4 * a * c;
        let x = [];
        if (delta > 0) {
            x = [(-b - Math.sqrt(delta)) / (2 * a), (-b + Math.sqrt(delta)) / (2 * a)];
        } else if (delta === 0) {
            x = [-b / (2 * a)];
        }
        setResult({ a, b, c, delta, x });
    }

    const show = k => values[k] === '' ? '0' : values[k];

    return (
        <div className="Calc">
            <div className="col">
                <h4><u>Przykladowe obliczenia</u></h4>
                {error && <p className="error">{error}</p>}
                <label htmlFor="a">prosze podac a: </label>
                <input id="a" value={values.a} onChange={handleChange} onBlur={handleBlur} /> <br />
                <label htmlFor="b">prosze podac b: </label>
                <input id="b" value={values.b} onChange={handleChange} onBlur={handleBlur} /> <br />
                <label htmlFor="c">prosze podac c: </label>
                <input id="c" value={values.c} onChange={handleChange} onBlur={handleBlur} />
                <hr />
                <h4>Rownanie o postaci:</h4>
                <p className="equation">{show('a')} x²+{show('b')}x+{show('c')}=0</p>
                <button onClick={calculate}>Oblicz</button>
                {result && (
                    <div className="result">
                        <p>delta={result.delta}</p>
                        {result.x.length === 2 && <>
                            <p>x1={result.x[0]}</p>
                            <p>x2={result.x[1]}</p>
                        </>}
                        {result.x.length === 1 && <p>x0={result.x[0]}</p>}
                        {result.x.length === 0 && <p>brak rozwiazan</p>}
                    </div>
                )}
            </div>
            <div className="col">
                <h4><u>Interpretacja graficzna:</u></h4>
                {result && <Graph {...result} />}
            </div>
        </div>
    );
}
