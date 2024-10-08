using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 启用援护技 message
 */
public class ReqGirlEnableAssistSkillMessage : Message 
{
	//援护技id
	int _assistSkill;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//援护技id
		SerializeUtils.WriteInt(stream, _assistSkill);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//援护技id
		_assistSkill = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 援护技id
	 */
	public int AssistSkill
	{
		set { _assistSkill = value; }
	    get { return _assistSkill; }
	}
	
	
	public override int GetId() 
	{
		return 108206;
	}
}