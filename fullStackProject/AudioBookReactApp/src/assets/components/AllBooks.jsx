import React, { useState, useEffect } from "react";
import AudioBookServices from "../services/AudioBookServices";
import { Link, useNavigate } from "react-router-dom";

function AllBooks() {
  const [audioBooks, setAudioBooks] = useState([]);

  const navigate = useNavigate();

  useEffect(() => {
    fetchData();
  }, []);

  const fetchData = () => {
    AudioBookServices.getAllBooks()
      .then((result) => {
        setAudioBooks(result.data);
      })
      .catch(() => {
        navigate("/");
      });
  };

  return (
    <div className="container mt-5">
      <div>
        <h1>Audio Books</h1>
        <hr />
      </div>
      <div className="mb-3">
        <a href="/add" className="btn btn-primary m-2">
          Add New Book
        </a>
      </div>
      <div className="m-2 p-3">
        <table className="table table-bordered table-hover">
          <thead>
            <tr>
              <th>Name</th>
              <th>Author</th>
              <th>Narrator</th>
              <th></th>
              <th></th>
              <th></th>
            </tr>
          </thead>
          <tbody>
            {audioBooks.map((book) => (
              <tr key={book.id}>
                <td>{book.name}</td>
                <td>{book.author}</td>
                <td>{book.narrator}</td>
                <td>
                  <Link to={`/edit/${book.id}`}>
                    <button className="btn btn-outline-primary">Edit</button>
                  </Link>
                </td>
                <td>
                  <Link to={`/delete/${book.id}`}>
                    <button className="btn btn-outline-danger">Delete</button>
                  </Link>
                </td>
                <td>
                  <Link to={`/details/${book.id}`}>
                    <button className="btn btn-outline-success">Details</button>
                  </Link>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
}

export default AllBooks;
