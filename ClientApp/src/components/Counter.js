import React, { useState } from 'react';

export const Counter = (props) => {
  const displayName = Counter.name;

 
  const [counter, setCounter] = useState (0)

  const incrementCounter = () => {
    setCounter(counter + 1);
  };

  return (
      <div>
        <h1>Counter</h1>

        <p>This is a simple example of a React component.</p>

        <p aria-live="polite">Current count: <strong>{counter}</strong></p>

        <button className="btn btn-primary" onClick={incrementCounter}>Increment</button>
      </div>
    );
  };

