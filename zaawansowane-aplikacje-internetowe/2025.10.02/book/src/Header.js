import { Component } from "react";
class Header extends Component{
    constructor(props){
        super(props);
        this.state = {
            nazwa : props.nazwa,
            miasto : props.miasto
        };
    }
    render(){
      return(<h1>Witamy w biblotece {this.state.nazwa} w {this.state.miasto}</h1>);
    };
}
export default Header;