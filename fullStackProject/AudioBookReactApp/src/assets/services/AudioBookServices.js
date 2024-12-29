import axios, { Axios } from "axios";

const path = "http://localhost:15425/api/Book";

class AudioBookServices {

  getAllBooks = () => {
    return axios.get(path);
  };

  addBook = (book) => {
    let myheader={"content-type":"application/json"};
    return axios.post(path, book, {headers:myheader});
  };

  getBookById = (id) => {
    return axios.get(`${path}/${id}`);
  };

  updateBook = (book) => {
    return axios.put(`${path}/${book.id}`, book);
  };

  deleteBook = (id) => {
    return axios.delete(`${path}/${id}`);
  };

}

export default new AudioBookServices