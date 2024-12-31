import React, { useState } from "react";
import UserService from "../services/UserService";
import { useNavigate } from "react-router-dom";

function LoginPage() {
  const [Username, setUsername] = useState("");
  const [Password, setPassword] = useState("");
  const [loginFailedMessage, setloginFailedMessage] = useState("");

  const navigate = useNavigate();

  const validate = (e) => {
    e.preventDefault();
    let user = { Username: Username, Password: Password };
    if (user != null) {
      UserService.authenticateUser(user)
        .then((result) => {
          if (result.status === 200) {
            console.log(result.data);
            navigate("/all");
          }
        })
        .catch(() => {
          setloginFailedMessage("Wrong Credentials. Check Username & Password");
        });
    } else {
      console.log("Please fill all necessary information");
    }
  };

  return (
    <div className="container mt-5">
      <div className="row justify-content-center">
        <div className="col-md-6 col-lg-4">
          <div className="card shadow-lg border-0">
            <div className="card-body">
              <h2 className="card-title text-center mb-4">Login</h2>
              {loginFailedMessage && (
                <div className="alert alert-danger">{loginFailedMessage}</div>
              )}
              <form onSubmit={validate} method="post">
                <div className="mb-3">
                  <label htmlFor="Username" className="form-label">
                    Username
                  </label>
                  <input type="text" className="form-control" id="Username" value={Username} required onChange={(e) => setUsername(e.target.value)} />
                </div>
                <div className="mb-3">
                  <label htmlFor="Password" className="form-label">
                    Password
                  </label>
                  <input type="password" className="form-control" id="Password" required value={Password} onChange={(e) => setPassword(e.target.value)} />
                </div>
                <div className="d-flex justify-content-between align-items-center">
                  <button type="submit" className="btn btn-primary w-100">Login</button>
                </div>
              </form>
              <hr />
              <div className="text-center">
                New Here?{" "}
                <a href="/register" className="btn btn-outline-primary btn-sm">
                  Register
                </a>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default LoginPage;
