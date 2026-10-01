import './App.css';
import { useState } from 'react';

export default function Book() {
  let [book] = useState(
    [
      {id: 0, title: "Hobbit", author: "JR Tolkien", pages: 300},
      {id: 1, title: "Władca pierścieni", author: "JR Tolkien", pages: 900},
      {id: 2, title: "Władca much", author: "W.Godlnig", pages: 250},
    ]
  );
  return (
    <div className="App">
      {book.map((item,index) =>(
        <ol>
          <h1>tytul: {item.title}</h1>
          <h1>autor: {item.author}</h1>
          <h1>ilosc stron: {item.pages}</h1>
        </ol>
        ))}
    </div>
  );
}
