import { Component } from "react";
import Header from './Header.js';
import Footer from './Footer.js';
import BookDesc from './BookDesc.js';
class Book extends Component {
    render(){
        return (
            <div className="App">
                <Header nazwa='Adama Mickiewicza' miasto='Poznaniu' />
                <BookDesc />
                <Footer />
            </div>
        )
    }
}

export default Book;