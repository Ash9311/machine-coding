import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import { CommentList } from './components/CommentList'

function App() {
  const [count, setCount] = useState(0)

  return (
    <div className="App">
      <h1>Nested Comments</h1>
      <CommentList />
    </div>
  )
}

export default App
