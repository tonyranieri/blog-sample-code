import React from "react";
import { Link } from "react-router-dom";

import "../App.css";

function accountSettings(props) {
  return (
    <div className="App">
      <header className="App-header">
        <h1>Account Settings</h1>
        <p>Manaage my account's settings...</p>

        <Link to="/" className="App-link">
          Home Page
        </Link>
      </header>
    </div>
  );
}

export default accountSettings;
