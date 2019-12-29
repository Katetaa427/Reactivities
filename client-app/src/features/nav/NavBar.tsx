import React from "react";
import { Menu, Container, Button } from "semantic-ui-react";

interface IProps {
  openCreateForm: () => void;
}

const NavBar: React.FC<IProps> = ({openCreateForm}) => {
  return (
    <Menu stackable>
      <Container>
        <Menu.Item>
          <img src="/assets/footprint2-512.png" alt="logo" style={{marginRight: '10px'}}></img>
          PRINTZ
        </Menu.Item>

        <Menu.Item className="">Home</Menu.Item>
        <Menu.Item className="">Activities</Menu.Item>
        <Menu.Item>
            <Button onClick={openCreateForm} positive content='Post A Tip'></Button> 
        </Menu.Item>


        <Menu.Item className="">Login</Menu.Item>
        <Menu.Item className="">Register</Menu.Item>
      </Container>
    </Menu>

    
  );
};

export default NavBar;
