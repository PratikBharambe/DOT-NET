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
        UserService.authenticateUser(user).then((result) => {
            if(result.status == 200){
              console.log(result.data);
                navigate("/all");
            }
        }).catch(() => {
            setloginFailedMessage("Wrong Credentials. Check Username & Password");
        });
    } else {
        console.log("Please fill all nescessasy information");
    }
  };

  return (
    <>
      <div className="container mt-5">
        <div className="row justify-content-center">
          <div className="col-md-6">
            <div className="card">
              <div className="card-body">
                <h1 className="card-title text-center">Login Page</h1>
                <div>
                    <p className="text-danger">{loginFailedMessage}</p>
                  <hr />
                </div>
                <form onSubmit={validate} method="post">
                  <div className="mb-3">
                    <label htmlFor="Username" className="form-label">
                      Username
                    </label>
                    <input
                      type="text"
                      className="form-control"
                      id="Username"
                      value={Username}
                      required
                      onChange={(e) => setUsername(e.target.value)}
                    />
                  </div>
                  <div className="mb-3">
                    <label htmlFor="Password" className="form-label">
                      Password
                    </label>
                    <input
                      type="password"
                      className="form-control"
                      id="Password"
                      required
                      value={Password}
                      onChange={(e) => setPassword(e.target.value)}
                    />
                  </div>
                  <button type="submit" className="btn btn-primary btn-block">
                    Login
                  </button>
                </form>
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  );
}

export default LoginPage;
