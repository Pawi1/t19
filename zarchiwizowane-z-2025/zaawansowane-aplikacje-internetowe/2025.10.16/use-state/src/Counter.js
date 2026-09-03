import { useState } from 'react';


export default function Counter() {
    const [count, setCount] = useState(0);
    return (
      <div>
        <p>Stan licznika: {count}</p>
        <br />
        
        <button onClick={() => setCount(count + 1)}>Zwieksz</button>
        <br />
        <button onClick={() => setCount(count - 1)}>Zmniejsz</button>
        <br />
        <br />
        <button onClick={() =>setCount(0)}>Reset</button>
      </div>
    );
}  