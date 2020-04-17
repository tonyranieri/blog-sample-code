import React from "react";
import { Link } from "react-router-dom";

export function homePage(props) {
  return (
    <div className="App">
      <header className="App-header">
        <h1>Sample Home Page</h1>
        <p>Some links to other components/pages</p>

        <Link to="/account" className="App-link">
          Account Settings
        </Link>

        <Link to="/users" className="App-link">
          User List
        </Link>
      </header>
    </div>
  );
}

export default homePage;
