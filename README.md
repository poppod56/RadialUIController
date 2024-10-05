# Radial UI Controller

A customizable Radial UI Controller for Unity that allows you to create interactive circular menus or radial layouts with various customizable properties such as radius, segment angle, gap, size, and rotation.

## Features

- **Customizable Radius**: Control the distance between the center and the child elements.
- **Partial Circle Segments**: Create full, half, quarter, or any segment of a circle.
- **Gap Control**: Add spacing between child elements for better visuals.
- **Size Controls**: Customize the size of the center element and child elements.
- **Rotation Offset**: Rotate the entire radial layout to any angle.
- **Easy Integration**: Simply add the package to your project and start creating radial menus.

## How to Install

### Option 1: Unity Package Manager (Recommended)

1. Open Unity and navigate to `Window > Package Manager`.
2. Click the `+` button in the top-left corner and select `Add package from git URL...`.
3. Paste the Git URL of this repository:
4. Unity will automatically import the package into your project.

### Option 2: Manual Installation

1. Download the latest version of this repository as a `.zip` file.
2. Extract the contents and copy the `Runtime` folder into your Unity project's `Assets` folder.

## Getting Started

### Setting Up the Radial UI

1. **Add the Radial UI Controller Script**:
- Create an empty GameObject in your scene.
- Attach the `RadialUIController` script (located in `Runtime/Scripts/`) to this GameObject.

2. **Add Child Elements**:
- Add UI elements (e.g., `Button`, `Image`) as children of the GameObject with the `RadialUIController`.
- These child elements will be arranged in a radial layout based on the settings.

3. **Customize the Layout**:
- Use the Inspector to adjust the settings for your radial layout:
  - **Radius**: Control how far the child elements are placed from the center.
  - **Center Radius**: Control the size of the center element.
  - **Child Size**: Control the size of each child element.
  - **Gap**: Control the spacing between each child element.
  - **Full Circle**: Toggle between a full circle or partial segment layout.
  - **Segment Angle**: For partial segments, set the angle of the segment.
  - **Rotation Offset**: Rotate the entire radial layout by a specified angle.

<!-- ### Example Scene

1. A sample scene is included in the package to demonstrate the radial UI layout (if applicable).
2. Open `Samples~/RadialUIExampleScene` to see a working example of the radial menu in action. -->
### Video Example
https://youtu.be/LrPBeADnbzk?si=e_u_smmlmaFdhsG6
## Usage Instructions

### Adjusting the Radial Layout

1. **Radius Control**: Set the `radius` to change how far child elements are from the center.
2. **Segment Control**: Toggle `fullCircle` to control whether the menu is a complete circle. If `false`, adjust the `segmentAngle` to create a half or quarter circle.
3. **Gap & Size Controls**: Use `gap`, `centerRadius`, and `childSize` to fine-tune the layout of your elements.
4. **Rotation**: Adjust `rotationOffset` to rotate the entire radial menu around its center.


## Contributing

Feel free to create issues or submit pull requests for any bugs or feature requests. For major changes, please open an issue to discuss your proposal.

## License

This package is distributed under the MIT License. See `LICENSE.md` for details.

## Support

If you encounter any issues or have questions, please reach out to `pop.podmenyou@gmail.com` or create an issue on the Git repository.

Happy developing with your new Radial UI Controller!

