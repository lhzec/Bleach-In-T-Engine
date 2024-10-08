using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队战对手番队信息 message
 */
public class ResGangBattleOpponentMessage : Message 
{
	//对手列表
	List<ArenaOpponentInfo> _opponentInfos = new List<ArenaOpponentInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//对手列表
		SerializeUtils.WriteShort(stream, (short)_opponentInfos.Count);

		foreach (var element in _opponentInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//对手列表
		int _opponentInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _opponentInfos_length; ++i) 
		{
			_opponentInfos.Add(SerializeUtils.ReadBean<ArenaOpponentInfo>(stream));
		}
	}
	
	/**
	 * get 对手列表
	 * @return 
	 */
	public List<ArenaOpponentInfo> GetOpponentInfos()
	{
		return _opponentInfos;
	}
	
	/**
	 * set 对手列表
	 */
	public void SetOpponentInfos(List<ArenaOpponentInfo> opponentInfos)
	{
		_opponentInfos = opponentInfos;
	}
	
	
	public override int GetId() 
	{
		return 112105;
	}
}