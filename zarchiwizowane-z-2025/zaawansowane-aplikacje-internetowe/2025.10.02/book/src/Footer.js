import { Component } from "react";

class Footer extends Component{
    data(){
        return new Date().toLocaleDateString("pl-PL");
    }
    render(){
        return(
            <h5>Dzisiaj jest: {<this.data />}</h5>
        );
    }
}
export default Footer;