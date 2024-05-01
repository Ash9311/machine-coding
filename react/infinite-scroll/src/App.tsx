import { useEffect, useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

const App = () => {
  const [count, setCount] = useState(50)
  useEffect(() => {
    const onScroll = () => {
      if (window.innerHeight + window.scrollY >= window.document.body.offsetHeight) {
        setCount(count + 50);
      }
    }

    window.addEventListener('scroll', onScroll);
// memory cleanup, remove listener
    return () => window.removeEventListener('scroll', onScroll);
  }, [count]);

  let elements = [];

  for (let i = 0; i < count; i++) {
    elements.push(<div key={i}>{i}</div>)
  }
  return (
    <>
      {elements}
    </>
  )
}

export default App
