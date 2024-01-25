import React, { useEffect } from "react"
import logo from "./logo.svg"
import "./App.css"
import axios from "axios"
import { BoredResponse } from "./BoredResponse"
import { Dog } from "./Dog"
import { base_api_url, config } from "./config"
import "../node_modules/bootstrap/dist/css/bootstrap.min.css"
import { Button, Card, ListGroup, ListGroupItem, Table } from "react-bootstrap"

function App() {
  const [pressCount, setPressCount] = React.useState(0)

  const [name, setName] = React.useState("")
  const [email, setEmail] = React.useState("")

  const [productName, setProductName] = React.useState("")
  const [productDescriere, setProductDescriere] = React.useState("")

  const [orders, setOrders] = React.useState<any[]>([])
  const [users, setUsers] = React.useState<any[]>([])
  const [products, setProducts] = React.useState<any[]>([])
  const fetchAllOrders = () => {
    axios.get(base_api_url + "/Order", config).then((response) => {
      setOrders(response.data)
    })
  }

  const fetchAllUsers = () => {
    axios.get(base_api_url + "/User", config).then((response) => {
      setUsers(response.data)
    })
  }

  const fetchAllProducts = () => {
    axios.get(base_api_url + "/Product", config).then((response) => {
      setProducts(response.data)
    })
  }

  useEffect(() => {
    fetchAllOrders()
    fetchAllUsers()
    fetchAllProducts()
  }, [])
  return (
    <div className="App">
      <header className="App-header">
        <Card>
          <Card.Title>Comenzi plasate</Card.Title>
          <Card.Body>
            <Table striped bordered hover size="sm" responsive>
              <thead>
                <tr>
                  <th>Id</th>
                  <th>UserId</th>
                  <th>Ora</th>
                  <th>Numar Produse</th>
                </tr>
              </thead>
              <tbody>
                {orders.map((order) => {
                  return (
                    <tr>
                      <td>{order.id}</td>
                      <td>{order.userId}</td>
                      <td>{order.createdAt}</td>
                      <td>{order.orderProducts.length}</td>
                    </tr>
                  )
                })}
              </tbody>
            </Table>
          </Card.Body>
        </Card>
        <h1>Adauga utilizator</h1>
        <form
          style={{ display: "flex", flexDirection: "column" }}
          onSubmit={(e) => {
            e.preventDefault()
          }}
        >
          <label> Nume </label>
          <input
            value={name}
            className="form-input"
            type="text"
            onChange={(e) => {
              setName(e.target.value)
            }}
          />
          <label> Email </label>
          <input
            value={email}
            className="form-input"
            type="text"
            onChange={(e) => {
              setEmail(e.target.value)
            }}
          />

          <Button
            variant="primary"
            className="mt-2 mb-2"
            onClick={() => {
              axios
                .post(
                  base_api_url + "/User",
                  {
                    name: name,

                    email: email,
                  },
                  config,
                )
                .then((response) => {
                  fetchAllUsers()
                })

              setEmail("")
              setName("")
            }}
          >
            Adauga utilizator
          </Button>
        </form>
        <label>Lista utilizatorilor</label>
        <Table striped bordered hover size="sm" responsive>
          <thead>
            <tr>
              <th>User Id</th>
              <th>Email</th>
              <th>Nume</th>
            </tr>
          </thead>
          <tbody>
            {users.map((order) => {
              return (
                <tr>
                  <td>{order.id}</td>
                  <td>{order.name}</td>
                  <td>{order.email}</td>
                </tr>
              )
            })}
          </tbody>
        </Table>
        <label>Lista produselor</label>
        <Table striped bordered hover size="sm" responsive>
          <thead>
            <tr>
              <th>Id</th>
              <th>Descriere</th>
            </tr>
          </thead>
          <tbody>
            {products.map((order) => {
              return (
                <tr>
                  <td>{order.id}</td>
                  <td>{order.descriere}</td>
                </tr>
              )
            })}
          </tbody>
        </Table>
        <h1>Adauga produs</h1>
        <form
          style={{ display: "flex", flexDirection: "column" }}
          onSubmit={(e) => {
            e.preventDefault()
          }}
        >
          <label> Nume </label>
          <input
            value={productName}
            className="form-input"
            type="text"
            onChange={(e) => {
              setProductName(e.target.value)
            }}
          />
          <label> Descriere </label>
          <input
            value={productDescriere}
            className="form-input"
            type="text"
            onChange={(e) => {
              setProductDescriere(e.target.value)
            }}
          />

          <Button
            variant="primary"
            className="mt-2 mb-2"
            onClick={() => {
              axios
                .post(
                  base_api_url + "/Product",
                  {
                    nume: productName,

                    descriere: productDescriere,
                  },
                  config,
                )
                .then((response) => {
                  fetchAllProducts()
                })

              setEmail("")
              setName("")
            }}
          >
            Adauga produs
          </Button>
        </form>
      </header>
    </div>
  )
}

export default App
