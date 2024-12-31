import React, { useState } from "react";
import UserService from "../services/UserService";

function RegisterUser() {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");

  const adduser = (e) => {
    e.preventDefault();
    let user = { Id : 0, Username: username, Password: password };
    console.log(user);
    UserService.addNewUser(user).then((result) => {
      if(result.status == 200){
        console.log("User added successfully")
      }
    }).catch(() => {
      console.log("erroe in user registration");
    })
  }

  return (
    <div className="container mt-5">
      <div className="row justify-content-center">
        <div className="col-md-6">
          <div className="card shadow-lg">
            <div className="card-header">
              <h1 className="text-center">Register</h1>
            </div>
            <div className="card-body">
              <form onSubmit={adduser} method="post">
                <div className="mb-3">
                  <label htmlFor="username" className="form-label">Username</label>
                  <input type="text" className="form-control" id="username" value={username} required onChange={(e) => setUsername(e.target.value)} />
                </div>
                <div className="mb-3">
                  <label htmlFor="password" className="form-label">Password</label>
                  <input type="password" className="form-control" id="password" value={password} required onChange={(e) => setPassword(e.target.value)} />
                </div>
                <div className="d-grid">
                  <button type="submit" className="btn btn-primary">
                    Register User
                  </button>
                </div>
              </form>
              <div className="mt-3 text-center">
                Already a user? <a href="/" className="btn btn-outline-primary">Login Here</a>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default RegisterUser;
