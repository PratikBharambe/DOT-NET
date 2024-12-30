import { BrowserRouter, Route, Routes } from "react-router-dom";
import AllBooks from "./assets/components/AllBooks";
import AddNewBook from "./assets/components/AddNewBook";
import Details from "./assets/components/Details";
import Edit from "./assets/components/Edit";
import Delete from "./assets/components/Delete";
import "./App.css";
import LoginPage from "./assets/components/LoginPage";
import RegisterUser from "./assets/components/RegisterUser";

function App() {
  return (
    <>
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<LoginPage />}></Route>
          <Route path="/register" element={<RegisterUser />}></Route>
          <Route path="/all" element={<AllBooks />}></Route>
          <Route path="/add" element={<AddNewBook />}></Route>
          <Route path="/edit/:id" element={<Edit />}></Route>
          <Route path="/details/:id" element={<Details />}></Route>
          <Route path="/delete/:id" element={<Delete />}></Route>
        </Routes>
      </BrowserRouter>
    </>
  );
}

export default App;
