import { Component } from "react";

class Book extends Component {
    constructor(props){
        super(props);
        this.state = {
            book: [
                {id:0,title:"Hobbit",author:"J.R. Tolkien",pages:300},
                {id:1,title:"Władca Pierścieni",author:"J.R. Tolkien",pages:500},
                {id:2,title:"Władca Much",author:"W.Godling",pages:250}
            ]
        };
    }
    render(){
        return (
            <div>
                {this.state.book.map((item)=>(
                    <ol>
                        <h1>tytul {item.title}</h1>
                        <h2>autor {item.author}</h2>
                        <h4>ilosc stron {item.pages}</h4>
                    </ol>
                ))}
            </div>
        )
    }
}

export default Book;