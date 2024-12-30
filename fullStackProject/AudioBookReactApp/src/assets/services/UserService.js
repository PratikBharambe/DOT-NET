import axios, { Axios } from "axios";

const path = "http://localhost:15425/api/User";
// const path = "http://localhost:15425/api/Book";

class UserService {

  authenticateUser = (user) =>{
    return axios.post(path, user);
  }

}

export default new UserService
