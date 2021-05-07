import React, { Component, useEffect, useState } from 'react';

export const Database = (props) => {
  const displayName = Database.name;

  const [state, setState] = useState({ people: [], loading: true });

  const populateData = async () => {
    if (state.loading) {
      const response = await fetch('people');
      const data = await response.json();
      setState({ people: data, loading: false });
    }
  }

  useEffect(() => {
    populateData();
  });

  const renderTable = (people) => {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
          </tr>
        </thead>
        <tbody>
          {people.map(person =>
            <tr key={person.id}>
              <td>{person.id}</td>
              <td>{person.name}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  const contents = state.loading
  if (contents) {
    return (<p><em>Loading...</em></p>);
  }
  else {
    return (
      <>
        <div>
          <h1 id="tabelLabel" >{displayName}</h1>
          <p>This component demonstrates fetching data from the server.</p>
          {renderTable(state.people)}
        </div>
      </>
    );
  }
}
