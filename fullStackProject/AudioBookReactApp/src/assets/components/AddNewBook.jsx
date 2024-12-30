import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import AudioBookServices from "../services/AudioBookServices";

function AddNewBook() {
  const [name, setName] = useState("");
  const [author, setAuthor] = useState("");
  const [narrator, setNarrator] = useState("");

  const navigate = useNavigate();

  const handleSubmit = (e) => {
    e.preventDefault();
    let audioBook = { name: name, author: author, narrator: narrator };
    if (name && author && narrator) {
      console.log(audioBook);
      AudioBookServices.addBook(audioBook).then((result) => {
        console.log(result);
        navigate("/all");
      });
    } else {
      alert("Please fill in all fields.");
    }
  };

  return (
    <div className="container mt-5">
      <h1>Add New AudioBook</h1>
      <hr />
      <form onSubmit={handleSubmit} method="post">
        <div className="mb-3">
          <label htmlFor="name" className="form-label">
            Name
          </label>
          <input
            type="text"
            className="form-control"
            id="name"
            value={name}
            onChange={(e) => setName(e.target.value)}
          />
        </div>
        <div className="mb-3">
          <label htmlFor="author" className="form-label">
            Author
          </label>
          <input
            type="text"
            className="form-control"
            id="author"
            value={author}
            onChange={(e) => setAuthor(e.target.value)}
          />
        </div>
        <div className="mb-3">
          <label htmlFor="narrator" className="form-label">
            Narrator
          </label>
          <input
            type="text"
            className="form-control"
            id="narrator"
            value={narrator}
            onChange={(e) => setNarrator(e.target.value)}
          />
        </div>
        <button type="submit" className="btn btn-primary">
          Add AudioBook
        </button>
      </form>
      <div>
        <br />
        <a href="/all" className="btn btn-outline-primary">
          Back To List
        </a>
      </div>
    </div>
  );
}

export default AddNewBook;
