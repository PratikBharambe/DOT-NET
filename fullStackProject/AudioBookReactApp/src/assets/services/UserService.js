import axios, { Axios } from "axios";

const path = "http://localhost:15425/api/User";

class UserService {

  authenticateUser = (user) =>{
    return axios.post(path, user);
  }

  addNewUser = (user) => {
    return axios.get(path, user);
  }

}

export default new UserService
