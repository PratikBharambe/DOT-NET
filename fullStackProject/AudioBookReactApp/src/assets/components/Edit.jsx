import React, { useState, useEffect } from "react";
import { useNavigate, useParams } from "react-router-dom";
import AudioBookServices from "../services/AudioBookServices";

function Edit() {
  const [name, setName] = useState("");
  const [author, setAuthor] = useState("");
  const [narrator, setNarrator] = useState("");
  const [id, setId] = useState("");

  const param = useParams();
  const navigate = useNavigate();

  useEffect(() => {
    AudioBookServices.getBookById(param.id)
      .then((result) => {
        setName(result.data.name);
        setAuthor(result.data.author);
        setNarrator(result.data.narrator);
        setId(result.data.id);
      })
      .catch((error) => {
        console.error("Error fetching book details:", error);
      });
  }, [param.id]);

  const handleSubmit = (e) => {
    e.preventDefault();
    let audioBook = { id: id, name: name, author: author, narrator: narrator };
    if (name && author && narrator) {
      console.log(audioBook);
      AudioBookServices.updateBook(audioBook).then((result) => {
        console.log(result);
        navigate("/all");
      });
    } else {
      alert("Please fill in all fields.");
    }
  };

  return (
    <div className="container mt-5">
      <h1>Update AudioBook Details</h1>
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
          Update AudioBook Details
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

export default Edit;
