import React from "react";
import { Link } from "react-router-dom";

function userList(props) {
  return (
    <div className="App">
      <header className="App-header">
        <h1>User List</h1>
        <p>List the app's users</p>

        <Link to="/" className="App-link">
          Home Page
        </Link>
      </header>
    </div>
  );
}

export default userList;
