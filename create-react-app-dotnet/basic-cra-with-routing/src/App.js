import React from "react";
import "./App.css";
import { BrowserRouter, Route, Switch } from "react-router-dom";

import HomePage from "./comps/homePage";
import AccountSettings from "./comps/accountSettings";
import UserList from "./comps/userList";
import NotFoundPage from "./comps/notFound";

function App() {
  return (
    <BrowserRouter basename="/admin">
      <Switch>
        <Route path="/" exact component={HomePage} />
        <Route path="/account" component={AccountSettings} />
        <Route path="/users" component={UserList} />
        <Route component={NotFoundPage} />
      </Switch>
    </BrowserRouter>
  );
}

export default App;
