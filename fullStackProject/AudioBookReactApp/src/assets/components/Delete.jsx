import React, { useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom";
import AudioBookServices from "../services/AudioBookServices";

function Delete() {
  const [audioBook, setAudioBook] = useState({});
  const param = useParams();
  const navigate = useNavigate();

  useEffect(() => {
    AudioBookServices.getBookById(param.id)
      .then((result) => {
        setAudioBook(result.data);
      })
      .catch((error) => {
        console.error("Error fetching book details:", error);
      });
  }, [param.id]);

  const deleteBook = (e) => {
    e.preventDefault();
    console.log(param.id);
    AudioBookServices.deleteBook(param.id).then((result) => {
      console.log(result);
      navigate("/all");
    });
  };

  return (
    <div className="container mt-4">
      <div className="text-center mb-4">
        <h1>Confirm Book To Delete</h1>
        <hr />
      </div>
      <div className="card shadow-lg p-4 mb-4">
        <div className="card-header bg-primary text-white">
          <h3 className="card-title">Book Information</h3>
        </div>

        <div className="card-body bg-light">
          <h3 className="card-title text-success">Name: {audioBook.name}</h3>
          <h5 className="card-subtitle mb-2 text-muted">
            Author: {audioBook.author}
          </h5>
          <p className="card-text text-secondary">
            Narrator: {audioBook.narrator}
          </p>
        </div>

        <form onSubmit={deleteBook} method="get">
          <div>
            <button className="btn btn-danger">Confirm Delete</button>
          </div>
        </form>
        <div>
          <br />
          <a href="/all" className="btn btn-outline-primary">
            Back To List
          </a>
        </div>
      </div>
    </div>
  );
}

export default Delete;
